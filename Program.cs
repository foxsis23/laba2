
//Скласти опис класу для дробу. Зберігає чисельник і знаменник звичайного дробу. 
//Методи: скоротити дріб, сума, різниця, добуток, розподіл двох дробів, 
//чи рівні два дроби, чи правильний дріб.

using DribClass;
using Newtonsoft.Json;

void main(){
    Drib drib1 = read_JSON("./file.json");
    Drib drib2 = new Drib(65, 6);

    drib1.GCD_Drib();

    drib1.sum(drib1, drib2);
    drib1.subtract(drib1, drib2);

    drib1.multiply(drib2, drib1);
    drib1.divide(drib2, drib1);

    drib1.equals(drib2, drib1);

    drib2.normal();

    // save_in_JSON(drib1);
}

void save_in_JSON(Drib d){
    string json = JsonConvert.SerializeObject(d, Formatting.Indented);
    File.WriteAllText(@"./file.json", json);
    Console.WriteLine("Об'єкт збережений у JSON файл.");
}

Drib read_JSON(string path){
    string json = File.ReadAllText(path);

    return JsonConvert.DeserializeObject<Drib>(json);
}

main();





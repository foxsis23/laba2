namespace DribClass{
    public class Drib{
        public int chiselnik;
        public int znamenik;
        
        public Drib(int chiselnik,int znamenik){
            this.chiselnik = chiselnik;
            this.znamenik = znamenik;
        }

        private int GCD(int znamenik,int chiselnik){
            while(chiselnik != 0){
                int temp = chiselnik;
                chiselnik = znamenik % chiselnik;
                znamenik = temp;
            }
            return znamenik;
        }

        private int LCM(int znamenik1, int znamenik2){
            return znamenik1 / GCD(znamenik1, znamenik2) * znamenik2;
        }

        public void GCD_Drib(){
            int gcd = GCD(znamenik, chiselnik);
            znamenik /= gcd;
            chiselnik /= gcd;
            Console.WriteLine($"Скорочений дріб: {chiselnik}/{znamenik}");
        }

        public void sum(Drib d1,Drib d2){
            int lcm = LCM(d1.znamenik, d2.znamenik);

            int sumChiselnik = d1.chiselnik * (lcm / d1.znamenik) + d2.chiselnik * (lcm / d2.znamenik);
            Console.WriteLine($"Результат суми дробів: {sumChiselnik}/{lcm}");
        }

        public void subtract(Drib d1,Drib d2){
            int lcm = LCM(d1.znamenik, d2.znamenik);

            int sumChiselnik = d1.chiselnik * (lcm / d1.znamenik) - d2.chiselnik * (lcm / d2.znamenik);
            Console.WriteLine($"Результат віднімання дробів: {sumChiselnik}/{lcm}");
        }

        public void multiply(Drib d1,Drib d2){
            int znamenik = d1.znamenik * d2.znamenik;
            int chiselnik = d1.chiselnik * d2.chiselnik;
            Console.WriteLine($"Результат множення: {chiselnik}/{znamenik}");
        }

        public void divide(Drib d1,Drib d2){
            int chiselnik = d1.znamenik * d2.chiselnik;
            int znamenik = d1.chiselnik * d2.znamenik;
            Console.WriteLine($"Результат ділення: {chiselnik}/{znamenik}");
        }

        public void equals(Drib d1,Drib d2){
            if(d1.znamenik == d2.znamenik && d1.chiselnik == d2.chiselnik){
                Console.WriteLine("Дроби рівні");
            }else{
                Console.WriteLine("Дроби різні");
            }         
        }

        public void normal(){
            if(chiselnik < znamenik){
                Console.WriteLine("Дріб правильний");
            }else{
                Console.WriteLine("Дріб неправильний");
            }
        }
    }
}
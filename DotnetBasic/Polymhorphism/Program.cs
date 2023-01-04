using System;

namespace Polymhorpism
{
    
        public abstract class HitungBagungDatar
    {
        public double luas;

        public abstract double HitungLuas();
    }
     
    public class Lingkaran : HitungBagungDatar
    {
        double JariJari;
        public Lingkaran(double r)
        {
            JariJari = r;
        }
        public override double HitungLuas()
        {
            luas =  3.14 * JariJari * JariJari;
            return luas;
        }

    }
     
    public class Segitiga : HitungBagungDatar
    {
        double alas, tinggi;
        
        public Segitiga(double a, double t)
        {
            alas = a;
            tinggi = t;
        }
        public override double HitungLuas()
        {
            luas = 0.5 * alas * tinggi;
            return luas;
        }
    }

}
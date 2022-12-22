using System;


namespace Lab3_sharp.Model
{
    public class Studio : ICloneable
    {
        public int Studio_name { get; set; }
        public int Workers_count { get; set; }
        public int Tune_price { get; set; }
        public int Tune_time { get; set; }
        public int Instruments { get; set; }

        public Studio(int name, int workers, int tune_price, int tune_time, int instr)
        {
            Studio_name = name;
            Workers_count = workers;
            Tune_price = tune_price;
            Tune_time = tune_time;
            Instruments = instr;
        }
        public object Clone()
        {
            return new Studio(Studio_name + 1, Workers_count, Tune_price, Tune_time, Instruments);
        }
        public Studio SetStudio_name(int name)
        {
            
            Studio_name = name;
            return this;
        }
        public Studio SetTune_price(int price)
        {
            Tune_price = price;
            return this;
        }
        public Studio SetTune_time(int time)
        {
            Tune_time = time;
            return this;
        }
        public Studio SetWorkers(int count)
        {
            Workers_count = count;
            return this;
        }
        public Studio SetInstruments(int count)
        {
            Instruments = count;
            return this;
        }
        public override string ToString()
        {

            return $"Кімната(id) : {Studio_name} Ціна :{Tune_price} Час: {Tune_time} " +
                $"Співробітники: {Workers_count} Інструменти: {Instruments}";

        }
    }
}

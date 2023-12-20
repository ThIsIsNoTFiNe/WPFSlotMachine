using System.ComponentModel;

namespace marconi.nicholas._4i.LibSlotMachine
{
    public class SlotMachine
    {
        //Qua definiamo la SlotMachineù
        public int credito { get; set; }

        public SlotMachine() 
        {
            credito = 0;
        }
        public SlotMachine(int credito) 
        {
            credito = credito;
        }
    }
}
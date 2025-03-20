namespace chaininresponsibilitypattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chainhandler ch = new ClusterHead();
            Chainhandler doctor = new Doctor();
            Chainhandler dD = new DD();
            Chainhandler examinationcell = new Examinationcell();
            ch.NextInChain(doctor);
            doctor.NextInChain(dD);
            dD.NextInChain(examinationcell);
            ch.request("Retake");
        }
    }
}

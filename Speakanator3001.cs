namespace ElectricInterfaces {
    public class Speakanator3001 : TurnTable {
        public int Volume {get;set;}
        public void VolumeUp() {
            Volume++;
        }
        public void VolumeDown() {
            Volume--;
        }
    }
}
namespace ElectricInterfaces {
    public interface ISpeaker
    {
        int Volume {get;set;}
        void VolumeUp();
        void VolumeDown();
    }
}
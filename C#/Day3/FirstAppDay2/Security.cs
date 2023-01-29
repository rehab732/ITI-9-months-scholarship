namespace FirstAppDay2
{
    [Flags]
    public enum Security : byte
    {
        guset = 0b_0000_0000, Developer = 0b_0000_0100, secretary = 0b_0000_0010, DBA = 0b_0000_0001,fullpermission=0b_0000_1111
    }
}


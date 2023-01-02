using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace DATC_lab_1;

public class Planta: TableEntity
{
    public string Latitudine
    { get; set; }

    public string Longitudine
    { get; set; }

    public string TipPlantaAlergena
    { get; set; }


    public Planta()
    {
        this.PartitionKey = "-";
        this.RowKey = "-";
        this.Latitudine = "-";
        this.Longitudine = "-";
        this.TipPlantaAlergena = "-";
    }

    public Planta(string partitionKey, string rowKey, string latitudine, string longitudine, string tipplantaalergena)
    {
        this.PartitionKey = partitionKey;
        this.RowKey = rowKey;
        this.Latitudine = latitudine;
        this.Longitudine = longitudine;
        this.TipPlantaAlergena = tipplantaalergena;
    }

}



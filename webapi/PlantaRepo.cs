using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace DATC_lab_1;

public class PlantaRepo: AzureTable
{
    public List<Planta> PlantaList = new List<Planta>();
    
    public PlantaRepo(string storageAccount, string storageKey, string tableName): 
        base(storageAccount, storageKey, tableName)
    {
        Console.WriteLine("A connection to the table named: " + tableName + " has been established\n");
    }

    public async Task<List<Planta>> GetAllPlante()
    {
        CloudTable table = await GetTable();
        TableQuery<Planta> query = new TableQuery<Planta>();
        List<Planta> plantaList = new List<Planta>();

        TableContinuationToken continuationToken = null;

        do{
            TableQuerySegment<Planta> queryResults = 
                await table.ExecuteQuerySegmentedAsync(query, continuationToken);
            continuationToken = queryResults.ContinuationToken;
            plantaList.AddRange(queryResults.Results);
        } while(continuationToken != null);

        return plantaList;
    }

    public async Task InsertPlanta(Planta planta)
    {
        CloudTable table = await GetTable();
        TableOperation insert_operation = TableOperation.Insert(planta);
        await table.ExecuteAsync(insert_operation);
    }

}

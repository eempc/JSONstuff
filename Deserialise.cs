using Newtonsoft.Json;

string json = @"{some JSON}";
var json1 = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(json);
var json2 = json1["data"]["quote"].ToString();
var json3 = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, object>>>(json2);
var json4 = json3["ETH"]["price"];
Console.WriteLine((double)json4);
Console.ReadKey();

// The JSON below is irregular, such that "status" and "data" are not the same, hence the use of the boxed variable object
// "data" has a nested object/dictionary, "quote" hence the second deserialisation:
{
    "status": {
        "timestamp": "2019-05-17T16:11:00.511Z",
        "error_code": 0,
        "error_message": null,
        "elapsed": 4,
        "credit_count": 1
    },
    "data": {
        "id": 2781,
        "symbol": "USD",
        "name": "United States Dollar",
        "amount": 100,
        "last_updated": "2019-05-17T16:10:00.000Z",
        "quote": {
            "ETH": {
                "price": 0.43841552086564745,
                "last_updated": "2019-05-17T16:10:23.000Z"
            }
        }
    }
}

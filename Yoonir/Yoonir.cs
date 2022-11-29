using Yoonir.Curseforge;
using Yoonir.Modrinth;
namespace Yoonir;

public partial class Yoonir
{
    private ModerinthApi? _modrinthApi;
    private CurseforgeApi? _curseforgeApi;
    public static Yoonir? Client { get; set; }

    public ApiType ApiType { get; set; } = ApiType.Automatic;

    private Yoonir(string curseforgeKey, string modrinthKey)
    {
        _modrinthApi = new ModerinthApi(modrinthKey);
        _curseforgeApi = new CurseforgeApi(curseforgeKey);
    }
    
    private Yoonir(ApiType type,string key)
    {
        switch (type)
        {
            case ApiType.Curseforge:
                _curseforgeApi = new CurseforgeApi(key);
                break;
            case ApiType.Modrinth:
                _modrinthApi = new ModerinthApi(key);
                break;
        }
    }

    public static Yoonir Create(ApiType type,string curseforgeKey)
    {
        return new Yoonir(type, curseforgeKey);
    }
    
    public static Yoonir Create(string curseforgeKey, string modrinthKey)
    {
        return new Yoonir(curseforgeKey,modrinthKey);
    }

    public async Task<object?> GetMod(string mod)
    {
        if (ApiType is ApiType.Modrinth)
        {
            return await _modrinthApi!.GetProject(mod);
        }

        if (ApiType is ApiType.Curseforge)
        {
            return await _curseforgeApi!.GetMod(mod);
        }

        try
        {
            return await _curseforgeApi!.GetMod(mod);
        }
        catch
        {
            try
            {
                return await _modrinthApi!.GetProject(mod);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

public enum ApiType
{
    // automatic: curseforge > modrinth
    Automatic,
    Curseforge,
    Modrinth
}
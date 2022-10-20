using MudSpeRece.Shared;

namespace MudSpeRece.Client.Services.ReceptionService
{
    public interface IReceptionService
    {
        // 受付データ定義
        List<Reception> Receptions { get; set; }

        // 受付データリスト読み込み
        Task GetReceptions();

        // 受付データ単体読み込み
        Task<Reception> GetSingleReception(int id);

        // 受付データ作成
        Task CreateReception(Reception reception);

        // 受付データ更新
        Task UpdateReception(Reception reception);

        // 受付データ削除
        Task DeleteReception(int id);

        // 受付データ検索読み込み
        Task GetSearchReceptions(Dictionary<string, string> queryParams);

    }
}

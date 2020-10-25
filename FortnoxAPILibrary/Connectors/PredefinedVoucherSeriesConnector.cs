using FortnoxAPILibrary.Entities;

using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
	/// <remarks/>
	public class PredefinedVoucherSeriesConnector : EntityConnector<PredefinedVoucherSeries, EntityCollection<PredefinedVoucherSeries>, Sort.By.PredefinedVoucherSeries?>, IPredefinedVoucherSeriesConnector
	{
		public PredefinedVoucherSeriesSearch Search { get; set; } = new PredefinedVoucherSeriesSearch();


		/// <remarks/>
		public PredefinedVoucherSeriesConnector()
		{
			Resource = "predefinedvoucherseries";
		}

		/// <summary>
		/// Find a predefinedVoucherSeries based on id
		/// </summary>
		/// <param name="id">Identifier of the predefinedVoucherSeries to find</param>
		/// <returns>The found predefinedVoucherSeries</returns>
		public PredefinedVoucherSeries Get(string id)
		{
			return GetAsync(id).Result;
		}

		/// <summary>
		/// Updates a predefinedVoucherSeries
		/// </summary>
		/// <param name="predefinedVoucherSeries">The predefinedVoucherSeries to update</param>
		/// <returns>The updated predefinedVoucherSeries</returns>
		public PredefinedVoucherSeries Update(PredefinedVoucherSeries predefinedVoucherSeries)
		{
			return UpdateAsync(predefinedVoucherSeries).Result;
		}

        /// <summary>
		/// Gets a list of predefinedVoucherSeriess
		/// </summary>
		/// <returns>A list of predefinedVoucherSeriess</returns>
		public EntityCollection<PredefinedVoucherSeries> Find()
		{
			return FindAsync().Result;
		}

		public async Task<EntityCollection<PredefinedVoucherSeries>> FindAsync()
		{
			return await BaseFind().ConfigureAwait(false);
		}
		public async Task<PredefinedVoucherSeries> UpdateAsync(PredefinedVoucherSeries predefinedVoucherSeries)
		{
			return await BaseUpdate(predefinedVoucherSeries, predefinedVoucherSeries.Name).ConfigureAwait(false);
		}
		public async Task<PredefinedVoucherSeries> GetAsync(string id)
		{
			return await BaseGet(id).ConfigureAwait(false);
		}
	}
}

using FortnoxAPILibrary.Entities;

using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global

namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public class TrustedEmailSendersConnector : EntityConnector<TrustedEmailSender, EntityWrapper<EmailSenders>, Sort.By.TrustedEmailSenders?>, ITrustedEmailSendersConnector
	{
		public TrustedEmailSendersSearch Search { get; set; } = new TrustedEmailSendersSearch();

		/// <remarks/>
		public TrustedEmailSendersConnector()
		{
			Resource = "emailsenders/trusted";
		}
		
		/// <summary>
		/// Creates a new trustedEmailSenders
		/// </summary>
		/// <param name="trustedEmailSenders">The trustedEmailSenders to create</param>
		/// <returns>The created trustedEmailSenders</returns>
		public TrustedEmailSender Create(TrustedEmailSender trustedEmailSenders)
		{
			return CreateAsync(trustedEmailSenders).Result;
		}

		/// <summary>
		/// Deletes a trustedEmailSenders
		/// </summary>
		/// <param name="id">Identifier of the trustedEmailSenders to delete</param>
		public void Delete(long? id)
		{
			DeleteAsync(id).Wait();
		}

        /// <summary>
        /// Retrieves all trusted and rejected emails with id.
        /// </summary>
        /// <returns>Collection of emails with id </returns>
        public EmailSenders Find()
        {
            return FindAsync().Result;
        }

        public async Task<TrustedEmailSender> CreateAsync(TrustedEmailSender trustedEmailSenders)
        {
            return await BaseCreate(trustedEmailSenders).ConfigureAwait(false);
        }

        public async Task DeleteAsync(long? id)
        {
            await BaseDelete(id.ToString()).ConfigureAwait(false);
        }

        public async Task<EmailSenders> FindAsync()
        {
            Resource = "emailsenders";
            var res = (await BaseFind().ConfigureAwait(false))?.Entity;
            Resource = "emailsenders/trusted";
            return res;
        }
	}
}

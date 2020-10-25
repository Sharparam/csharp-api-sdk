using FortnoxAPILibrary.Entities;
using System.Threading.Tasks;

// ReSharper disable UnusedMember.Global
namespace FortnoxAPILibrary.Connectors
{
    /// <remarks/>
    public interface ITrustedEmailSendersConnector : IEntityConnector
	{
		TrustedEmailSendersSearch Search { get; set; }

        TrustedEmailSender Create(TrustedEmailSender trustedEmailSenders);
        void Delete(long? id);
        EmailSenders Find();

        Task<TrustedEmailSender> CreateAsync(TrustedEmailSender trustedEmailSenders);
        Task DeleteAsync(long? id);
        Task<EmailSenders> FindAsync();
	}
}

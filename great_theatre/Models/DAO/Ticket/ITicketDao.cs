using System.Collections.Generic;

namespace great_theatre.Models.DAO.Ticket
{
	public interface ITicketDao
	{
        void Add();
        void Edit();
        void Delete();
        Enities.Ticket Lead(int id);
        List<Enities.Ticket> Load(int skip, int take);
	}
}
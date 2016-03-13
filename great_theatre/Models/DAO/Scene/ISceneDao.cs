using System.Collections.Generic;

namespace great_theatre.Models.DAO.Scene
{
	public interface ISceneDao
	{
        void Add(Entities.Scene scene);
        void Edit(Entities.Scene scene);
        void Delete(Entities.Scene scene);
        Entities.Scene Lead(int id);
        List<Entities.Scene> Load(int skip, int take);
	}
}
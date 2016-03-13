﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace great_theatre.Models.DAO.Scene
{
	public class SceneDao : ISceneDao
	{
	    public void Add(Entities.Scene scene)
	    {
            using (var context = new ApplicationDbContext())
            {
                context.Scenes.Add(scene);
                context.SaveChanges();
            }
	    }

	    public void Edit(Entities.Scene scene)
	    {
	        using (var context = new ApplicationDbContext())
            {
                context.Entry(scene).State = EntityState.Modified;
                context.SaveChanges();
            }
	    }

	    public void Delete(Entities.Scene scene)
	    {
            using (var context = new ApplicationDbContext())
            {
                var deleteItem = context.Scenes.FirstOrDefault(p => p.Id == scene.Id);
                if (deleteItem == null)
                    return;
                context.Scenes.Remove(deleteItem);
                context.SaveChanges();
            }

	    }

	    public Entities.Scene Lead(int id)
	    {
            Entities.Scene scene;
            using (var context = new ApplicationDbContext())
            {
                scene = context.Scenes.FirstOrDefault(p => p.Id == id);
            }
            return scene;
	    }

	    public List<Entities.Scene> Load(int skip, int take)
	    {
            List<Entities.Scene> scenes;
            using (var context = new ApplicationDbContext())
            {
                scenes = context.Scenes.OrderBy(s => s.Tickets).Skip(skip).Take(take).ToList();
            }
            return scenes;
	    }
	}
}
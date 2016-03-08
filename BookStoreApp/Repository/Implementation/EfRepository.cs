﻿using BookStoreApp.Repository.Interface;
using BookStoreApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Repository.Implementation
{
	public class EfRepository:IRepository
	{
		private BookStoreContext db = new BookStoreContext();

		public async Task<IEnumerable<Books>> GetBooks(string genre)
		{
			return await db.Book.Where(r=>r.Genre.Name==genre).ToListAsync();
		}
		public IEnumerable<Genres> GetGenres()
		{
			return db.Genre.ToList();
		}
	}
}

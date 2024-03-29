﻿using System;
using System.Collections.Generic;
using PhoneBook.Core.Context;
using PhoneBook.Entities;

namespace PhoneBook.Core.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly PhoneBookDbContext _context;
        public ContactRepository()
        {
            _context = new PhoneBookDbContext();
        }
        

        public int Add(Contact entity)
        {
            int result;
            try
            {
                _context.Contacts.Add(entity);
                _context.SaveChanges(_context.Contacts);
                result = 1;
            }
            catch (Exception e)
            {
                result = 0;
                throw;
            }


            return result;
        }

        public int Delete(Guid id)
        {
            int res;
            try
            {
                var entity = _context.Contacts.Find(x => x.Id == id);
                if (entity==null) { return res=0; }
                _context.Contacts.Remove(entity);
                _context.SaveChanges(_context.Contacts);
               res= 1;

            }
            catch(Exception e)
            {
                res = 0;
                throw;
            }
            return res;
        }

        public List<Contact> GetAll()
        {
            return _context.Contacts;
        }

        public int Update(Contact request)
        {
             int result;
                try
                {
                    var entity = _context.Contacts.Find(i => i.Id == request.Id);

                    if (entity == null)
                    {
                        return result = 0;
                    }

                    entity.Name = request.Name;
                    entity.Surname = request.Surname;
                    entity.Email = request.Email;
                    entity.Website = request.Website;
                    entity.Address = request.Address;
                    entity.Description = request.Description;
                    entity.Number1 = request.Number1;
                    entity.Number2 = request.Number2;
                    entity.Number3 = request.Number3;

                    _context.SaveChanges(_context.Contacts);

                    result = 1;
                }
                catch (Exception e)
                {
                    result = 0;
                    throw;
                }


                return result;
            }
        }



    }

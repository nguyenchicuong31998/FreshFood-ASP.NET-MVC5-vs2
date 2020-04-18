﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebsiteThucPhamSach_VS2.Models;
namespace WebsiteThucPhamSach_VS2.Areas.Dashboard.Models
{
    public class RolesModel
    {
        FreshFoodEntities db = new FreshFoodEntities();

        public List<role> getRoles()
        {
            return db.roles.ToList();
        }

        public role getRoleById(int id)
        {
            var role = db.roles.SingleOrDefault(r => r.id == id);
            if(role != null)
            {
                return role;
            }
            return null;
        }

        public bool createRole(role role)
        {
            try
            {
                db.roles.Add(role);
                db.SaveChanges();
                return true;
            }catch(Exception e)
            {

            }
            return false;
        }

        public bool updateRoleById(int id, role updateRole)
        {
            var currentRole = this.getRoleById(id);
            if (currentRole != null)
            {
                 currentRole.name= updateRole.name;
                 db.Entry(currentRole).State = EntityState.Modified;
                 db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool deleteRoleById(int id)
        {
            var role = this.getRoleById(id);
            if(role != null)
            {
                db.roles.Remove(role);
                db.SaveChanges();
                return true;
            }
            return false;
        }

    }
}
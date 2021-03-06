﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SportEvents.Core;

namespace SportEvents.Core
{
    public class SportEventsService
    {

        public List<Događaj> GetDogađaji()
        {
            using (var db = new SportEventDBEntities())
            {
                var događaji = db.Događaj.OrderBy(d => d.datum).ToList();
                foreach (Događaj d in događaji)
                {
                    d.Mjesto = db.Mjesto.Where(m => m.pk_mjesto == d.fk_mjesto).Single();
                    d.Mjesto.Grad = db.Grad.Where(g => g.pk_grad == d.Mjesto.fk_grad).Single();
                    d.Sport = db.Sport.Where(s => s.pk_sport == d.fk_sport).Single();
                    d.DogađajNatjecatelj = db.DogađajNatjecatelj.Where(dn => dn.fk_događaj == d.pk_događaj).ToList();

                    foreach (DogađajNatjecatelj dn in d.DogađajNatjecatelj)
                    {
                        dn.Natjecatelj = db.Natjecatelj.Where(n => n.pk_natjecatelj == dn.fk_natjecatelj).Single();
                    }

                }
                return događaji;
            }
        }

        public Događaj GetDogađaj(int pk_događaj)
        {
            using (var db = new SportEventDBEntities())
            {
                var događaj = db.Događaj.Where(d => d.pk_događaj == pk_događaj).Single();
                
                događaj.Mjesto = db.Mjesto.Where(m => m.pk_mjesto == događaj.fk_mjesto).Single();
                događaj.Mjesto.Grad = db.Grad.Where(g => g.pk_grad == događaj.Mjesto.fk_grad).Single();
                događaj.Sport = db.Sport.Where(s => s.pk_sport == događaj.fk_sport).Single();
                događaj.DogađajNatjecatelj = db.DogađajNatjecatelj.Where(dn => dn.fk_događaj == događaj.pk_događaj).ToList();
                foreach (DogađajNatjecatelj dn in događaj.DogađajNatjecatelj)
                {
                    dn.Natjecatelj = db.Natjecatelj.Where(n => n.pk_natjecatelj == dn.fk_natjecatelj).Single();
                }
                                
                return događaj;
            }
        }

        public List<Događaj> GetDogađajiN(int n)
        {
            using (var db = new SportEventDBEntities())
            {
                var događaji = db.Događaj.OrderBy(d => d.datum).Take(n).ToList();
                foreach (Događaj d in događaji)
                {
                    d.Mjesto = db.Mjesto.Where(m => m.pk_mjesto == d.fk_mjesto).Single();
                    d.Mjesto.Grad = db.Grad.Where(g => g.pk_grad == d.Mjesto.fk_grad).Single();
                    d.Sport = db.Sport.Where(s => s.pk_sport == d.fk_sport).Single();
                    d.DogađajNatjecatelj = db.DogađajNatjecatelj.Where(dn => dn.fk_događaj == d.pk_događaj).ToList();

                    foreach (DogađajNatjecatelj dn in d.DogađajNatjecatelj)
                    {
                        dn.Natjecatelj = db.Natjecatelj.Where(nat => nat.pk_natjecatelj == dn.fk_natjecatelj).Single();
                    }

                }
                return događaji;
            }


        }

        public List<Sport> GetSportovi()
        {
            using (var db = new SportEventDBEntities())
            {
                return db.Sport.ToList();
            }

        }

        public List<Događaj> GetSportDogađaji(int pk_sport)
        {
            using (var db = new SportEventDBEntities())
            {
                var događaji = db.Događaj.Where(d => d.fk_sport == pk_sport).OrderBy(d => d.datum).ToList();
                foreach (Događaj d in događaji)
                {
                    d.Mjesto = db.Mjesto.Where(m => m.pk_mjesto == d.fk_mjesto).Single();
                    d.Mjesto.Grad = db.Grad.Where(g => g.pk_grad == d.Mjesto.fk_grad).Single();
                    d.Sport = db.Sport.Where(s => s.pk_sport == d.fk_sport).Single();
                    d.DogađajNatjecatelj = db.DogađajNatjecatelj.Where(dn => dn.fk_događaj == d.pk_događaj).ToList();

                    foreach (DogađajNatjecatelj dn in d.DogađajNatjecatelj)
                    {
                        dn.Natjecatelj = db.Natjecatelj.Where(nat => nat.pk_natjecatelj == dn.fk_natjecatelj).Single();
                    }


                }

                return događaji;
            }
        }

        public List<Grad> GetGradovi()
        {
            using (var db = new SportEventDBEntities())
            {
                return db.Grad.ToList();
            }

        }

        public List<Mjesto> GetMjestaGrad(int pk_grad)
        {
            using (var db = new SportEventDBEntities())
            {
                var mjesta = db.Mjesto.Where(m => m.fk_grad == pk_grad).ToList();
                foreach (Mjesto m in mjesta)
                {
                    m.Događaj = db.Događaj.Where(d => d.fk_mjesto == m.pk_mjesto).ToList();
                    foreach(Događaj d in m.Događaj)
                    {                        
                        d.Sport = db.Sport.Where(s => s.pk_sport == d.fk_sport).Single();
                        d.DogađajNatjecatelj = db.DogađajNatjecatelj.Where(dn => dn.fk_događaj == d.pk_događaj).ToList();

                        foreach (DogađajNatjecatelj dn in d.DogađajNatjecatelj)
                        {
                            dn.Natjecatelj = db.Natjecatelj.Where(nat => nat.pk_natjecatelj == dn.fk_natjecatelj).Single();
                        }
                    }                    
                    
                }

                return mjesta;
            }
        }
    }
}
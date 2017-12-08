﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestAJAXDataTables.Models;

namespace TestAJAXDataTables.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pagination_With_Data_Table_issue_getData(TableParameter param)
        {
            var data = new[]{   
                new []{"Trident test","Internet Explorer 4.0","Win 95+","4","X"},
	            new []{"Trident","Internet Explorer 5.0","Win 95+","5","C"},
	            new []{"Trident","Internet Explorer 5.5","Win 95+","5.5","A"},
	            new []{"Trident","Internet Explorer 6","Win 98+","6","A"},
	            new []{"Trident","Internet Explorer 7","Win XP SP2+","7","A"},
	            new []{"Trident","AOL browser (AOL desktop)","Win XP","6","A"},
	            new []{"Gecko","Firefox 1.0","Win 98+ / OSX.2+","1.7","A"},
	            new []{"Gecko","Firefox 1.5","Win 98+ / OSX.2+","1.8","A"},
	            new []{"Gecko","Firefox 2.0","Win 98+ / OSX.2+","1.8","A"},
	            new []{"Gecko","Firefox 3.0","Win 2k+ / OSX.3+","1.9","A"},
	            new []{"Gecko","Camino 1.0","OSX.2+","1.8","A"},
	            new []{"Gecko","Camino 1.5","OSX.3+","1.8","A"},
	            new []{"Gecko","Netscape 7.2","Win 95+ / Mac OS 8.6-9.2","1.7","A"},
	            new []{"Gecko","Netscape Browser 8","Win 98SE+","1.7","A"},
	            new []{"Gecko","Netscape Navigator 9","Win 98+ / OSX.2+","1.8","A"},
	            new []{"Gecko","Mozilla 1.0","Win 95+ / OSX.1+","1","A"},
	            new []{"Gecko","Mozilla 1.1","Win 95+ / OSX.1+","1.1","A"},
	            new []{"Gecko","Mozilla 1.2","Win 95+ / OSX.1+","1.2","A"},
	            new []{"Gecko","Mozilla 1.3","Win 95+ / OSX.1+","1.3","A"},
	            new []{"Gecko","Mozilla 1.4","Win 95+ / OSX.1+","1.4","A"},
	            new []{"Gecko","Mozilla 1.5","Win 95+ / OSX.1+","1.5","A"},
	            new []{"Gecko","Mozilla 1.6","Win 95+ / OSX.1+","1.6","A"},
	            new []{"Gecko","Mozilla 1.7","Win 98+ / OSX.1+","1.7","A"},
	            new []{"Gecko","Mozilla 1.8","Win 98+ / OSX.1+","1.8","A"},
	            new []{"Gecko","Seamonkey 1.1","Win 98+ / OSX.2+","1.8","A"},
	            new []{"Gecko","Epiphany 2.20","Gnome","1.8","A"},
	            new []{"Webkit","Safari 1.2","OSX.3","125.5","A"},
	            new []{"Webkit","Safari 1.3","OSX.3","312.8","A"},
	            new []{"Webkit","Safari 2.0","OSX.4+","419.3","A"},
	            new []{"Webkit","Safari 3.0","OSX.4+","522.1","A"},
	            new []{"Webkit","OmniWeb 5.5","OSX.4+","420","A"},
	            new []{"Webkit","iPod Touch / iPhone","iPod","420.1","A"},
	            new []{"Webkit","S60","S60","413","A"},
	            new []{"Presto","Opera 7.0","Win 95+ / OSX.1+","-","A"},
	            new []{"Presto","Opera 7.5","Win 95+ / OSX.2+","-","A"},
	            new []{"Presto","Opera 8.0","Win 95+ / OSX.2+","-","A"},
	            new []{"Presto","Opera 8.5","Win 95+ / OSX.2+","-","A"},
	            new []{"Presto","Opera 9.0","Win 95+ / OSX.3+","-","A"},
	            new []{"Presto","Opera 9.2","Win 88+ / OSX.3+","-","A"},
	            new []{"Presto","Opera 9.5","Win 88+ / OSX.3+","-","A"},
	            new []{"Presto","Opera for Wii","Wii","-","A"},
	            new []{"Presto","Nokia N800","N800","-","A"},
	            new []{"Presto","Nintendo DS browser","Nintendo DS","8.5","C/A<sup>1</sup>"},
	            new []{"KHTML","Konqureror 3.1","KDE 3.1","3.1","C"},
	            new []{"KHTML","Konqureror 3.3","KDE 3.3","3.3","A"},
	            new []{"KHTML","Konqureror 3.5","KDE 3.5","3.5","A"},
	            new []{"Tasman","Internet Explorer 4.5","Mac OS 8-9","-","X"},
	            new []{"Tasman","Internet Explorer 5.1","Mac OS 7.6-9","1","C"},
	            new []{"Tasman","Internet Explorer 5.2","Mac OS 8-X","1","C"},
	            new []{"Misc","NetFront 3.1","Embedded devices","-","C"},
	            new []{"Misc","NetFront 3.4","Embedded devices","-","A"},
	            new []{"Misc","Dillo 0.8","Embedded devices","-","X"},
	            new []{"Misc","Links","Text only","-","X"},
	            new []{"Misc","Lynx","Text only","-","X"},
	            new []{"Misc","IE Mobile","Windows Mobile 6","-","C"},
	            new []{"Misc","PSP browser","PSP","-","C"},
	            new []{"Other browsers","All others","-","-","U"}
            };

            var pagedData = data.Skip(param.iDisplayStart).Take(param.iDisplayLength);

            return Json(new
            {
                sEcho = param.sEcho,
                iTotalRecords = data.Count(),
                iTotalDisplayRecords = data.Count(),
                aaData = pagedData
            }, JsonRequestBehavior.AllowGet);
        }

    }
}

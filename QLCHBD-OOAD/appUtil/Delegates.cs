﻿using QLCHBD_OOAD.model.images;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//this is use for define delegate
namespace QLCHBD_OOAD.appUtil
{
     public delegate void ChangePageHandler(string page);
     public delegate void BackHandler();
     public delegate void AddImageHandler(Images newImages);
    public delegate void ToggleFormDialogNotifyHandler();
    public delegate void DeleteImageHandler(long id);
}

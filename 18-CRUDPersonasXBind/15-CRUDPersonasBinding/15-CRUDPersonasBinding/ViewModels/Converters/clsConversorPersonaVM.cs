﻿using _15_CRUDPersonasBinding_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace _15_CRUDPersonasBinding.ViewModels.Converters
{
    class clsConversorPersonaVM : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            clsPersona oPersona = null;

            if (value!=null)
            {
                oPersona = (clsPersona) value;
            }

            return oPersona;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return value;
        }
    }
}

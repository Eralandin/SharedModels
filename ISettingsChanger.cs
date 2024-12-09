using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public interface ISettingsChanger
    {
        void ChangeFontSizeInForm(Control? parent, float newSize);
    }
}

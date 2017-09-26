using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTurnos
{
    public class JerarquiaRoot : JerarquiaMenu
    {
        private static JerarquiaRoot root;

        public static JerarquiaRoot Root
        {
            get
            {
                if (root == null)
                {
                    root = new JerarquiaRoot();
                }

                return root;
            }
        }

        private JerarquiaRoot() : base("root") { }
    }
}
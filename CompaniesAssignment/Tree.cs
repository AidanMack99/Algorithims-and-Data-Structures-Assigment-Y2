using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompaniesAssignment
{
    class Tree : AVLTree<Company>
    {
        public List<Company> GetallCompanies()
        {
            List<Company> companies = new List<Company>();
            getallCompanies(root, companies);
            return companies;
        }

        public void getallCompanies(Node<Company> tree, List<Company> companies)
        {
            if(tree!=null)
            {
                getallCompanies(tree.Left, companies);
                companies.Add(tree.Data);
                getallCompanies(tree.Right, companies);
            }
        }
    }
}

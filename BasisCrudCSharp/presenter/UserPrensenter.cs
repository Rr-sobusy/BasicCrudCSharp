using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicCrudCSharp.model;
using BasicCrudCSharp.view;
using System.Windows.Forms;
namespace BasicCrudCSharp.presenter
{
    public class UserPrensenter
    {
        private readonly IUserModel _model;
        private readonly IUserView _view;

        List<IUserModel> Users = new List<IUserModel>();

        public UserPrensenter(IUserView view, IUserModel model)
        {
            _model = model;
            _view = view;
            _view.AddNewRecord += addRecordHandler;
        }

        private void addRecordHandler(object sender, EventArgs e)
        {
            _model.Name = _view.Name;
            _model.Age = _view.Age;
            _model.Email = _view.Email;
            IUserModel NewRecord = new UserModel() { Name = _model.Name, Age = _model.Age, Email = _model.Email };
            Users.Add(NewRecord);

            //Refresh the data grid view
            _view.RefreshDGV(Users);


        }


    }
}

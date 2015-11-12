using SignUp.ViewModel;
using SignUp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignUp.Repository;


namespace SignUp.Business
{
    class MemberBusiness
    {
        public void SaveMember(MemberViewModel _memberViewModel)
        {
            if (_memberViewModel.MemberName==null)
            {
                throw new Exception("Membername in not null!");
            }
            if (_memberViewModel.MemberPassword1==null)
            {
                throw new Exception("Password 1 is not null!");
            }
            if (_memberViewModel.MemberPassword2==null)
            {
                throw new Exception("Password 2 is not null!");
            }
            if (_memberViewModel.MemberPassword1!=_memberViewModel.MemberPassword2)
            {
                throw new Exception("Passwords does not match!");
            }
            else
            {
                MemberDataModel _newMember = new MemberDataModel();
                _newMember.MemberName = _memberViewModel.MemberName;
                _newMember.MemberPassword = _memberViewModel.MemberPassword1;
                MemberRepository _newMemberRepository = new MemberRepository();
                _newMemberRepository.SaveMember(_newMember);
                
            }
        }
    }
}

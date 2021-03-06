﻿using Bll.Abstract;
using Bll.Concrete;
using Dto;
using System.Collections.Generic;

namespace Visitor
{
    public class VisitorObj
    {
        private readonly UserDto Information;

        public IUserBll User = new UserBll();
        private readonly IPurchaseHistoryBll PurchaseHistory;

        public VisitorObj(string nickname, string password)
        {
            Information = User.SignIn(nickname, password);
            PurchaseHistory = new PurchaseHistoryBll(Information.Nickname);
        }
        public List<string> GetTags()
        {
            List<string> Tags = new List<string>();
            IPurchaseHistoryBll PurchaseHistoryFullList = new PurchaseHistoryBll(Information.Nickname);
            foreach (var el in PurchaseHistoryFullList.GetList())
            {
                Tags.Add(el.Type);
            }
            if (Tags.Count==0)
            {
                return null;
            }
            return Tags;
        }
        public IPurchaseHistoryBll GetPurchaseHistoryBll()
        {
            return PurchaseHistory;
        }
        public UserDto GetUserDataWithoutSecretInfo()
        {
            return new UserDto(Information.Nickname, "Secret", Information.Name, Information.Surname, Information.PhoneNumber.Value, Information.BornDate,Information.Address, Information.Question, "Secret");
        }
    }
}

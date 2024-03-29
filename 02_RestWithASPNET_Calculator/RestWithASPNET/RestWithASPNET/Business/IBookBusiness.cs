﻿using System.Collections.Generic;
using RestWithASPNET.Data.VO;
using RestWithASPNET.Model;

namespace RestWithASPNET.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindByID(long id);
        List<BookVO> FindAll();
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}

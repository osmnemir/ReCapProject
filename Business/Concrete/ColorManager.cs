using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntitiyFremework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {

        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public Color Add(Color color)
        {
            throw new NotImplementedException();
        }

        public Color Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Color GetById(int id)
        {
            return _colorDal.Get(color=>color.Id == id);
        }

        public Color Update(Color color)
        {
            throw new NotImplementedException();
        }
    }
}

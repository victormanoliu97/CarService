using System.Collections.Generic;
using System.Linq;
using CarServiceCore.Context;
using CarServiceCore.Utils.Transformer;

namespace CarServiceCore.Repository.ImageRepository
{
    public class ImageRepositoryImpl : IMageRepository
    {
        private readonly Entities _applicationContext;

        public ImageRepositoryImpl(Entities applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void AddImage(Imagine image)
        {
            if (image == null) return;
            if (_applicationContext.Imagines.FirstOrDefault(i => i.ImagineId == image.ImagineId) != null) return;
            _applicationContext.Imagines.Add(image);
            _applicationContext.SaveChanges();
        }

        public void DeleteImage(int imageId)
        {
            if (imageId == null) return;
            var image = _applicationContext.Imagines.FirstOrDefault(i => i.ImagineId == imageId);
            if (image == null) return;
            
            var queryToGetOrderDetailsForMechanic = from orderDetails in _applicationContext.DetaliiComandas
                where orderDetails.ImagineId == imageId
                select orderDetails;

            foreach (var orderDetailsImage in queryToGetOrderDetailsForMechanic.ToList())
            {
                orderDetailsImage.ImagineId = 0;
            }
            
            _applicationContext.Imagines.Remove(image);
            _applicationContext.SaveChanges();
        }

        public void UpdateImage(Imagine image)
        {
            if (image == null) return;
            if (_applicationContext.Imagines.FirstOrDefault(i => i.ImagineId == image.ImagineId) == null) return;
            var clonedImage = image;
            ImageTransformer.MergeImageEntities(clonedImage, image);
            _applicationContext.SaveChanges();
        }

        public List<Comanda> GetImagesForOrder(Imagine image, Comanda order)
        {
            if (order == null) return null;
            if (_applicationContext.Comandas.FirstOrDefault(i => i.ComandaId == order.ComandaId) == null) return null;

            var query = from o in _applicationContext.Comandas
                where o.ComandaId == order.ComandaId
                select o;

            return query.Any() ? query.ToList() : null;
        }
    }
}
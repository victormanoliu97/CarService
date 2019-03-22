using System.Collections.Generic;
using CarServiceCore.Context;

namespace CarServiceCore.Repository.ImageRepository
{
    public interface IMageRepository
    {
        void AddImage(Imagine image);

        void DeleteImage(int imageId);

        void UpdateImage(Imagine image);

        List<Comanda> GetImagesForOrder(Imagine image, Comanda order);
    }
}
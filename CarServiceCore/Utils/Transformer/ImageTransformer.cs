using CarServiceCore.Context;

namespace CarServiceCore.Utils.Transformer
{
    public abstract class ImageTransformer
    {
        public static void MergeImageEntities(Imagine dbImage, Imagine foundImage)
        {
            dbImage.Descriere = foundImage.Descriere;
            dbImage.Titlu = foundImage.Titlu;
            dbImage.DataImagine = foundImage.DataImagine;
            dbImage.Foto = foundImage.Foto;
        }
    }
}
using CarServiceCore.Context;

namespace CarServiceCore.Utils.Transformer
{
    public abstract class MaterialTransformer
    {
        public static void MergeMaterialEntities(Material dbMaterial, Material foundMaterial)
        {
            dbMaterial.Denumire = foundMaterial.Denumire;
            dbMaterial.Cantitate = foundMaterial.Cantitate;
            dbMaterial.Pret = foundMaterial.Pret;
            dbMaterial.DataAprovizionare = foundMaterial.DataAprovizionare;
            dbMaterial.Pret = foundMaterial.Pret;
            dbMaterial.DataAprovizionare = foundMaterial.DataAprovizionare;
        }
    }
}
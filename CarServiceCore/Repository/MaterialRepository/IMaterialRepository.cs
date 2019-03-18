using System.Collections.Generic;
using CarServiceCore.Context;

namespace CarServiceCore.Repository.MaterialRepository
{
    public interface IMaterialRepository
    {
        List<Material> GetMaterials();

        void AddMaterial(Material material);

        bool MaterialExists(Material material);

        void DeleteMaterial(Material material);

        void UpdateMaterial(Material material);

        List<Material> PartialMaterialSearch(Material material);
    }
}
using System.Collections.Generic;
using System.Linq;
using CarServiceCore.Context;
using CarServiceCore.Utils.Transformer;

namespace CarServiceCore.Repository.MaterialRepository
{
    public class MaterialRepository : IMaterialRepository
    {
        private readonly Entities _applicationContext;

        public MaterialRepository(Entities applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public List<Material> GetMaterials()
        {
            return _applicationContext.Materials.ToList();
        }

        public void AddMaterial(Material material)
        {
            if (material == null) return;
            if (MaterialExists(material)) return;
            _applicationContext.Materials.Add(material);
            _applicationContext.SaveChanges();
        }

        public bool MaterialExists(Material material)
        {
            if (material == null) return false;
            var foundMaterial = _applicationContext.Materials.FirstOrDefault(m => m.MaterialId == material.MaterialId);
            return foundMaterial != null;
        }

        public void DeleteMaterial(Material material)
        {
            if (material == null) return;
            if (MaterialExists(material))
            {
                _applicationContext.Materials.Add(material);
                _applicationContext.SaveChanges();
            }
        }

        public void UpdateMaterial(Material material)
        {
            if (material == null) return;
            if (MaterialExists(material))
            {
                var clonedMaterial = material;
                MaterialTransformer.MergeMaterialEntities(clonedMaterial, material);
            }

            _applicationContext.SaveChanges();
        }

        public List<Material> PartialMaterialSearch(Material material)
        {
            if (material == null) return null;

            var queryByName = _applicationContext.Materials.Where(m => m.Denumire.Contains(material.Denumire));

            return queryByName.Any() ? queryByName.ToList() : null;
        }
    }
}
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repositorios.Queries {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Material_Queries {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Material_Queries() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Repositorios.Queries.Material_Queries", typeof(Material_Queries).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE material 
        ///SET descricao = @descricao, 
        ///	tipo_material_id = @tipo_material_id, 
        ///	cor_id = @cor_id, 
        ///	quantidade = @quantidade 
        ///WHERE id = @id.
        /// </summary>
        internal static string AlterarMaterial {
            get {
                return ResourceManager.GetString("AlterarMaterial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE material 
        ///SET quantidade = quantidade + @quantidade 
        ///WHERE id = @id.
        /// </summary>
        internal static string AlterarQuantidadeMaterial {
            get {
                return ResourceManager.GetString("AlterarQuantidadeMaterial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM material 
        ///WHERE id = @id.
        /// </summary>
        internal static string ApagarMaterial {
            get {
                return ResourceManager.GetString("ApagarMaterial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE TABLE IF NOT EXISTS material
        ///	(id INTEGER PRIMARY KEY, 
        ///	descricao VARCHAR(30), 
        ///	tipo_material_id INTEGER, 
        ///	cor_id INTEGER, 
        ///	quantidade INTEGER, 
        ///
        ///	FOREIGN KEY(tipo_material_id) 
        ///	REFERENCES tipo_material(id), 
        ///	FOREIGN KEY(cor_id) REFERENCES cor(id)).
        /// </summary>
        internal static string CriarTabelaMaterial {
            get {
                return ResourceManager.GetString("CriarTabelaMaterial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO material
        ///	(descricao, 
        ///	tipo_material_id, 
        ///	cor_id, 
        ///	quantidade) 
        ///VALUES(@descricao, 
        ///	@tipo_material_id, 
        ///	@cor_id, 
        ///	@quantidade).
        /// </summary>
        internal static string InserirMaterial {
            get {
                return ResourceManager.GetString("InserirMaterial", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT	material.id, 
        ///		material.descricao, 
        ///		material.tipo_material_id, 
        ///		tipo_material.descricao, 
        ///		material.cor_id, 
        ///		cor.descricao, 
        ///		cor.valorARGB,
        ///		material.quantidade
        ///FROM material
        ///	INNER JOIN tipo_material ON tipo_material.id = material.tipo_material_id
        ///	INNER JOIN cor ON cor.id = material.cor_id.
        /// </summary>
        internal static string ObterMateriais {
            get {
                return ResourceManager.GetString("ObterMateriais", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT id, 
        ///	descricao, 
        ///	tipo_material_id, 
        ///	cor_id, 
        ///	quantidade 
        ///FROM material 
        ///WHERE id = @id.
        /// </summary>
        internal static string ObterMaterialPorId {
            get {
                return ResourceManager.GetString("ObterMaterialPorId", resourceCulture);
            }
        }
    }
}

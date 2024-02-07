﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Consignment1.  ISO2002 ID# _Tms--9p-Ed-ak6NoX_4Aeg_-1622845025.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Physical packaging of goods for transport.
/// </summary>
public partial record Consignment1
     : IIsoXmlSerilizable<Consignment1>
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of packaging units, eg number of boxes, containers, pallets, etc.
    /// </summary>
    public Quantity3? TotalQuantity { get; init; } 
    /// <summary>
    /// Total volume of goods shipped, eg number of cubic meters.
    /// </summary>
    public Quantity3? TotalVolume { get; init; } 
    /// <summary>
    /// Total weight of goods shipped, eg number of kg, tons.
    /// </summary>
    public Quantity3? TotalWeight { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (TotalQuantity is Quantity3 TotalQuantityValue)
        {
            writer.WriteStartElement(null, "TtlQty", xmlNamespace );
            TotalQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalVolume is Quantity3 TotalVolumeValue)
        {
            writer.WriteStartElement(null, "TtlVol", xmlNamespace );
            TotalVolumeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalWeight is Quantity3 TotalWeightValue)
        {
            writer.WriteStartElement(null, "TtlWght", xmlNamespace );
            TotalWeightValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Consignment1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

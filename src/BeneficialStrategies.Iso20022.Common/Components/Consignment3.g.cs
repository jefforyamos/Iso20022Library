﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Consignment3.  ISO2002 ID# _Iue04TAPEeOKib24wnHaFg.
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
public partial record Consignment3
     : IIsoXmlSerilizable<Consignment3>
{
    #nullable enable
    
    /// <summary>
    /// Total quantity of packaging units, eg number of boxes, containers, pallets, etc.
    /// </summary>
    public Quantity10? TotalQuantity { get; init; } 
    /// <summary>
    /// Total volume of goods shipped, eg number of cubic meters.
    /// </summary>
    public Quantity10? TotalVolume { get; init; } 
    /// <summary>
    /// Total weight of goods shipped, eg number of kg, tons.
    /// </summary>
    public Quantity10? TotalWeight { get; init; } 
    
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
        if (TotalQuantity is Quantity10 TotalQuantityValue)
        {
            writer.WriteStartElement(null, "TtlQty", xmlNamespace );
            TotalQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalVolume is Quantity10 TotalVolumeValue)
        {
            writer.WriteStartElement(null, "TtlVol", xmlNamespace );
            TotalVolumeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (TotalWeight is Quantity10 TotalWeightValue)
        {
            writer.WriteStartElement(null, "TtlWght", xmlNamespace );
            TotalWeightValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static Consignment3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

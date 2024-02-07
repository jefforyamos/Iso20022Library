﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralMovement9.  ISO2002 ID# _WPYN8ILaEeWrrO9HojbPQA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of collateral that will be delivered and the date to be reported.
/// </summary>
public partial record CollateralMovement9
     : IIsoXmlSerilizable<CollateralMovement9>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of collateral.
    /// </summary>
    public required CollateralType1Code CollateralType { get; init; } 
    /// <summary>
    /// Date by which the collateral movement must be executed.
    /// </summary>
    public IsoISODate? Date { get; init; } 
    
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
        writer.WriteStartElement(null, "CollTp", xmlNamespace );
        writer.WriteValue(CollateralType.ToString()); // Enum value
        writer.WriteEndElement();
        if (Date is IsoISODate DateValue)
        {
            writer.WriteStartElement(null, "Dt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(DateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
    }
    public static CollateralMovement9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

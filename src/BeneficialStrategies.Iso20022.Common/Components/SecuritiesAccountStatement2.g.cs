﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesAccountStatement2.  ISO2002 ID# _QDcSkeGBEeWCAvUNsZ5u6g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides system date for all of the changes occurred for an entity.
/// </summary>
public partial record SecuritiesAccountStatement2
     : IIsoXmlSerilizable<SecuritiesAccountStatement2>
{
    #nullable enable
    
    /// <summary>
    /// Date for which the statement is valid.
    /// </summary>
    public required IsoISODate SystemDate { get; init; } 
    /// <summary>
    /// Provides information on the actual change occurred to a securities account.
    /// </summary>
    public SecuritiesAccountReferenceDataChange2? Change { get; init; } 
    
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
        writer.WriteStartElement(null, "SysDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(SystemDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        if (Change is SecuritiesAccountReferenceDataChange2 ChangeValue)
        {
            writer.WriteStartElement(null, "Chng", xmlNamespace );
            ChangeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SecuritiesAccountStatement2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

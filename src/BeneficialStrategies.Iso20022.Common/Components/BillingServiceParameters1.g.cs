﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BillingServiceParameters1.  ISO2002 ID# _6PgXwZqlEeGSON8vddiWzQ_-423301635.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the detailed parameters a service to be billed.
/// </summary>
public partial record BillingServiceParameters1
     : IIsoXmlSerilizable<BillingServiceParameters1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the details to fully identify the bank service.
    /// </summary>
    public required BillingServiceIdentification1 BankService { get; init; } 
    /// <summary>
    /// Count or number of items (volume) involved in the charge.
    /// </summary>
    public IsoDecimalNumber? Volume { get; init; } 
    
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
        writer.WriteStartElement(null, "BkSvc", xmlNamespace );
        BankService.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Volume is IsoDecimalNumber VolumeValue)
        {
            writer.WriteStartElement(null, "Vol", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoDecimalNumber(VolumeValue)); // data type DecimalNumber System.UInt64
            writer.WriteEndElement();
        }
    }
    public static BillingServiceParameters1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

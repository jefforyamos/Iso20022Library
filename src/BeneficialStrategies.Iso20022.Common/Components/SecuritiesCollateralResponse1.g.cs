﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SecuritiesCollateralResponse1.  ISO2002 ID# _Si43QWT3EeSnseycwS8fpA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides more details on the response such as the response type, the collateral identification, and optionally further details in case of rejection.
/// </summary>
public partial record SecuritiesCollateralResponse1
     : IIsoXmlSerilizable<SecuritiesCollateralResponse1>
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    public IsoMax35Text? CollateralIdentification { get; init; } 
    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    public IsoMax35Text? AssetNumber { get; init; } 
    /// <summary>
    /// Specifies the status of the collateral proposal.
    /// </summary>
    public required Status4Code ResponseType { get; init; } 
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    public RejectionReasonV021Code? RejectionReason { get; init; } 
    /// <summary>
    /// Additional information regarding why the collateral proposal has a rejected status.
    /// </summary>
    public IsoMax35Text? RejectionInformation { get; init; } 
    
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
        if (CollateralIdentification is IsoMax35Text CollateralIdentificationValue)
        {
            writer.WriteStartElement(null, "CollId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CollateralIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AssetNumber is IsoMax35Text AssetNumberValue)
        {
            writer.WriteStartElement(null, "AsstNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AssetNumberValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "RspnTp", xmlNamespace );
        writer.WriteValue(ResponseType.ToString()); // Enum value
        writer.WriteEndElement();
        if (RejectionReason is RejectionReasonV021Code RejectionReasonValue)
        {
            writer.WriteStartElement(null, "RjctnRsn", xmlNamespace );
            writer.WriteValue(RejectionReasonValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (RejectionInformation is IsoMax35Text RejectionInformationValue)
        {
            writer.WriteStartElement(null, "RjctnInf", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(RejectionInformationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
    }
    public static SecuritiesCollateralResponse1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

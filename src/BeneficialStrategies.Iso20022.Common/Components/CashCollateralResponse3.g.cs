﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CashCollateralResponse3.  ISO2002 ID# _2Q43cStIEeyOa655cLd-DQ.
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
public partial record CashCollateralResponse3
     : IIsoXmlSerilizable<CashCollateralResponse3>
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of the collateral proposal.
    /// </summary>
    public required Status4Code ResponseType { get; init; } 
    /// <summary>
    /// Provides the identification of the proposed collateral.
    /// </summary>
    public IsoMax35Text? CollateralIdentification { get; init; } 
    /// <summary>
    /// Identifies the register number of the collateral deposit assigned by the central counterparty.
    /// </summary>
    public IsoMax35Text? AssetNumber { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public AccountIdentification4Choice_? CashAccountIdentification { get; init; } 
    /// <summary>
    /// Specifies the reason why the instruction/cancellation request has a rejected status.
    /// </summary>
    public RejectionReason68Code? RejectionReason { get; init; } 
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
        writer.WriteStartElement(null, "RspnTp", xmlNamespace );
        writer.WriteValue(ResponseType.ToString()); // Enum value
        writer.WriteEndElement();
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
        if (CashAccountIdentification is AccountIdentification4Choice_ CashAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "CshAcctId", xmlNamespace );
            CashAccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RejectionReason is RejectionReason68Code RejectionReasonValue)
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
    public static CashCollateralResponse3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

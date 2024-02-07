﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AccountSubLevel22.  ISO2002 ID# _Mhe_8_NyEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed ownership information about the shareholding quantity to be disclosed,  or the shareholding quantity not to be disclosed and the shareholding quantity below threshold.
/// </summary>
public partial record AccountSubLevel22
     : IIsoXmlSerilizable<AccountSubLevel22>
{
    #nullable enable
    
    /// <summary>
    /// Quantity of shares for which shareholding details are not disclosed.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? NonDisclosedShareholdingQuantity { get; init; } 
    /// <summary>
    /// Quantity of shares for which shareholding details are not reported as the quantity of shares owned by the shareholder is under the threshold limit.
    /// </summary>
    public FinancialInstrumentQuantity18Choice_? BelowThresholdShareholdingQuantity { get; init; } 
    /// <summary>
    /// Details of the account sub-levels and holdings.
    /// </summary>
    public AccountSubLevel23? Disclosure { get; init; } 
    
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
        if (NonDisclosedShareholdingQuantity is FinancialInstrumentQuantity18Choice_ NonDisclosedShareholdingQuantityValue)
        {
            writer.WriteStartElement(null, "NonDscldShrhldgQty", xmlNamespace );
            NonDisclosedShareholdingQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BelowThresholdShareholdingQuantity is FinancialInstrumentQuantity18Choice_ BelowThresholdShareholdingQuantityValue)
        {
            writer.WriteStartElement(null, "BlwThrshldShrhldgQty", xmlNamespace );
            BelowThresholdShareholdingQuantityValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Disclosure is AccountSubLevel23 DisclosureValue)
        {
            writer.WriteStartElement(null, "Dsclsr", xmlNamespace );
            DisclosureValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static AccountSubLevel22 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

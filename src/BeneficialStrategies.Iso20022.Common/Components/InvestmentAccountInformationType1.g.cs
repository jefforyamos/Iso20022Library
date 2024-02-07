﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccountInformationType1.  ISO2002 ID# _RR2AZNp-Ed-ak6NoX_4Aeg_1677189755.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Select the type(s) of information to be retrieved about a registered investment account.
/// </summary>
public partial record InvestmentAccountInformationType1
     : IIsoXmlSerilizable<InvestmentAccountInformationType1>
{
    #nullable enable
    
    /// <summary>
    /// Indicates if the core investment account information must be selected.
    /// </summary>
    public required IsoYesNoIndicator InvestmentAccount { get; init; } 
    /// <summary>
    /// Indicates if the information about account parties must be selected.
    /// </summary>
    public required IsoYesNoIndicator AccountParties { get; init; } 
    /// <summary>
    /// Indicates if the information about the intermediaries must be selected.
    /// </summary>
    public required IsoYesNoIndicator Intermediaries { get; init; } 
    /// <summary>
    /// Indicates if the information about the investment plan(s) must be selected.
    /// </summary>
    public required IsoYesNoIndicator InvestmentPlan { get; init; } 
    /// <summary>
    /// Indicates if the cash settlement information must be selected.
    /// </summary>
    public required IsoYesNoIndicator CashSettlement { get; init; } 
    /// <summary>
    /// Indicates if the Service Level Agreement information must be selected.
    /// </summary>
    public required IsoYesNoIndicator ServiceLevelAgreement { get; init; } 
    
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
        writer.WriteStartElement(null, "InvstmtAcct", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(InvestmentAccount)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "AcctPties", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(AccountParties)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Intrmies", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(Intermediaries)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "InvstmtPlan", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(InvestmentPlan)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "CshSttlm", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(CashSettlement)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SvcLvlAgrmt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(ServiceLevelAgreement)); // data type YesNoIndicator System.String
        writer.WriteEndElement();
    }
    public static InvestmentAccountInformationType1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

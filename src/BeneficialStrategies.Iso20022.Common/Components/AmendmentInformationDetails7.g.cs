﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmendmentInformationDetails7.  ISO2002 ID# _TDrxctp-Ed-ak6NoX_4Aeg_2077407286.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide the list of direct debit mandate elements that have been modified when the amendment indicator has been set.
/// </summary>
public partial record AmendmentInformationDetails7
     : IIsoXmlSerilizable<AmendmentInformationDetails7>
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the original mandate.
    /// </summary>
    public IsoMax35Text? OriginalMandateIdentification { get; init; } 
    /// <summary>
    /// Original creditor scheme identification that has been modified.
    /// </summary>
    public PartyIdentification43? OriginalCreditorSchemeIdentification { get; init; } 
    /// <summary>
    /// Original creditor agent that has been modified.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? OriginalCreditorAgent { get; init; } 
    /// <summary>
    /// Original debtor that has been modified.
    /// </summary>
    public PartyIdentification43? OriginalDebtor { get; init; } 
    /// <summary>
    /// Original debtor account that has been modified.
    /// </summary>
    public CashAccount16? OriginalDebtorAccount { get; init; } 
    /// <summary>
    /// Original debtor agent that has been modified.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? OriginalDebtorAgent { get; init; } 
    /// <summary>
    /// Original final collection date that has been modified.
    /// </summary>
    public IsoISODate? OriginalFinalCollectionDate { get; init; } 
    /// <summary>
    /// Original frequency that has been modified.
    /// </summary>
    public Frequency1Code? OriginalFrequency { get; init; } 
    
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
        if (OriginalMandateIdentification is IsoMax35Text OriginalMandateIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlMndtId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(OriginalMandateIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (OriginalCreditorSchemeIdentification is PartyIdentification43 OriginalCreditorSchemeIdentificationValue)
        {
            writer.WriteStartElement(null, "OrgnlCdtrSchmeId", xmlNamespace );
            OriginalCreditorSchemeIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalCreditorAgent is BranchAndFinancialInstitutionIdentification5 OriginalCreditorAgentValue)
        {
            writer.WriteStartElement(null, "OrgnlCdtrAgt", xmlNamespace );
            OriginalCreditorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalDebtor is PartyIdentification43 OriginalDebtorValue)
        {
            writer.WriteStartElement(null, "OrgnlDbtr", xmlNamespace );
            OriginalDebtorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalDebtorAccount is CashAccount16 OriginalDebtorAccountValue)
        {
            writer.WriteStartElement(null, "OrgnlDbtrAcct", xmlNamespace );
            OriginalDebtorAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalDebtorAgent is BranchAndFinancialInstitutionIdentification5 OriginalDebtorAgentValue)
        {
            writer.WriteStartElement(null, "OrgnlDbtrAgt", xmlNamespace );
            OriginalDebtorAgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OriginalFinalCollectionDate is IsoISODate OriginalFinalCollectionDateValue)
        {
            writer.WriteStartElement(null, "OrgnlFnlColltnDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(OriginalFinalCollectionDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (OriginalFrequency is Frequency1Code OriginalFrequencyValue)
        {
            writer.WriteStartElement(null, "OrgnlFrqcy", xmlNamespace );
            writer.WriteValue(OriginalFrequencyValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
    }
    public static AmendmentInformationDetails7 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

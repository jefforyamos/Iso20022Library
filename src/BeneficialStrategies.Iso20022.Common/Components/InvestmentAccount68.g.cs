﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InvestmentAccount68.  ISO2002 ID# _Gmv7c4fuEeevKP8c-ilVhA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account between an investor(s) and a fund manager or a fund. The account can contain holdings in any investment fund or investment fund class managed (or distributed) by the fund manager, within the same fund family.
/// </summary>
public partial record InvestmentAccount68
     : IIsoXmlSerilizable<InvestmentAccount68>
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public PartyIdentification113? OwnerIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification for the account between the account owner and the account servicer.
    /// </summary>
    public required IsoMax35Text AccountIdentification { get; init; } 
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    public IsoMax35Text? AccountName { get; init; } 
    /// <summary>
    /// Supplementary registration information applying to a specific block of units for dealing and reporting purposes. The supplementary registration information may be used when all the units are registered, for example, to a funds supermarket, but holdings for each investor have to reconciled individually.
    /// </summary>
    public IsoMax35Text? AccountDesignation { get; init; } 
    /// <summary>
    /// Party that provides services relating to financial products to investors, for example, advice on products and placement of orders for the investment fund.
    /// </summary>
    public Intermediary42? IntermediaryInformation { get; init; } 
    /// <summary>
    /// Form, that is, ownership, of the security, that is, registered or bearer.
    /// </summary>
    public FormOfSecurity1Code? SecuritiesForm { get; init; } 
    /// <summary>
    /// Indicates whether a security exists only as an electronic record, that is, there is no physical document representing the security.
    /// </summary>
    public IsoYesNoIndicator? DematerialisedIndicator { get; init; } 
    /// <summary>
    /// Dividend option chosen by the account owner based on the options offered in the prospectus.
    /// </summary>
    public IncomePreference2Code? IncomePreference { get; init; } 
    /// <summary>
    /// Beneficial owner or its designated agent certifies that it complies with any holding or investment restrictions or requirements of the fund.
    /// </summary>
    public BeneficiaryCertificationCompletion1Code? BeneficiaryCertificationCompletion { get; init; } 
    /// <summary>
    /// Place requested as the place of safekeeping.
    /// </summary>
    public SafekeepingPlaceFormat8Choice_? SafekeepingPlace { get; init; } 
    /// <summary>
    /// Institution that maintains the records where the account is held.
    /// </summary>
    public PartyIdentification113? AccountServicer { get; init; } 
    /// <summary>
    /// Sub-accounts that are grouped in a master or omnibus account.
    /// </summary>
    public SubAccount5? SubAccountDetails { get; init; } 
    
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
        if (OwnerIdentification is PartyIdentification113 OwnerIdentificationValue)
        {
            writer.WriteStartElement(null, "OwnrId", xmlNamespace );
            OwnerIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "AcctId", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountIdentification)); // data type Max35Text System.String
        writer.WriteEndElement();
        if (AccountName is IsoMax35Text AccountNameValue)
        {
            writer.WriteStartElement(null, "AcctNm", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountNameValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (AccountDesignation is IsoMax35Text AccountDesignationValue)
        {
            writer.WriteStartElement(null, "AcctDsgnt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(AccountDesignationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (IntermediaryInformation is Intermediary42 IntermediaryInformationValue)
        {
            writer.WriteStartElement(null, "IntrmyInf", xmlNamespace );
            IntermediaryInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecuritiesForm is FormOfSecurity1Code SecuritiesFormValue)
        {
            writer.WriteStartElement(null, "SctiesForm", xmlNamespace );
            writer.WriteValue(SecuritiesFormValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (DematerialisedIndicator is IsoYesNoIndicator DematerialisedIndicatorValue)
        {
            writer.WriteStartElement(null, "DmtrlsdInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(DematerialisedIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (IncomePreference is IncomePreference2Code IncomePreferenceValue)
        {
            writer.WriteStartElement(null, "IncmPref", xmlNamespace );
            writer.WriteValue(IncomePreferenceValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (BeneficiaryCertificationCompletion is BeneficiaryCertificationCompletion1Code BeneficiaryCertificationCompletionValue)
        {
            writer.WriteStartElement(null, "BnfcryCertfctnCmpltn", xmlNamespace );
            writer.WriteValue(BeneficiaryCertificationCompletionValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (SafekeepingPlace is SafekeepingPlaceFormat8Choice_ SafekeepingPlaceValue)
        {
            writer.WriteStartElement(null, "SfkpgPlc", xmlNamespace );
            SafekeepingPlaceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccountServicer is PartyIdentification113 AccountServicerValue)
        {
            writer.WriteStartElement(null, "AcctSvcr", xmlNamespace );
            AccountServicerValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SubAccountDetails is SubAccount5 SubAccountDetailsValue)
        {
            writer.WriteStartElement(null, "SubAcctDtls", xmlNamespace );
            SubAccountDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static InvestmentAccount68 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ISATransfer12.  ISO2002 ID# _33Wr4RwnEeOIveEnnb_1-A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
public partial record ISATransfer12
     : IIsoXmlSerilizable<ISATransfer12>
{
    #nullable enable
    
    /// <summary>
    /// Information identifying the primary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    public IndividualPerson8? PrimaryIndividualInvestor { get; init; } 
    /// <summary>
    /// Information identifying the secondary individual investor, eg, name, address, social security number and date of birth.
    /// </summary>
    public IndividualPerson8? SecondaryIndividualInvestor { get; init; } 
    /// <summary>
    /// Information identifying the other individual investors, eg, name, address, social security number and date of birth.
    /// </summary>
    public IndividualPerson8? OtherIndividualInvestor { get; init; } 
    /// <summary>
    /// Information identifying the primary corporate investor, eg, name and address.
    /// </summary>
    public Organisation4? PrimaryCorporateInvestor { get; init; } 
    /// <summary>
    /// Information identifying the secondary corporate investor, eg, name and address.
    /// </summary>
    public Organisation4? SecondaryCorporateInvestor { get; init; } 
    /// <summary>
    /// Information identifying the other corporate investors, eg, name and address.
    /// </summary>
    public Organisation4? OtherCorporateInvestor { get; init; } 
    /// <summary>
    /// Identification of an account owned by the investor at the old plan manager (account servicer).
    /// </summary>
    public required Account15 TransferorAccount { get; init; } 
    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    public Account16? NomineeAccount { get; init; } 
    /// <summary>
    /// Information related to the institution to which the financial instrument is to be transferred.
    /// </summary>
    public required PartyIdentification2Choice_ Transferee { get; init; } 
    /// <summary>
    /// Identification of an account owned by the investor to which a cash entry is made based on the transfer of asset(s).
    /// </summary>
    public CashAccount29? CashAccount { get; init; } 
    /// <summary>
    /// Details of the transfer to be cancelled.
    /// </summary>
    public required ISATransfer17 ProductTransferAndReference { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public Extension1? Extension { get; init; } 
    
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
        if (PrimaryIndividualInvestor is IndividualPerson8 PrimaryIndividualInvestorValue)
        {
            writer.WriteStartElement(null, "PmryIndvInvstr", xmlNamespace );
            PrimaryIndividualInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondaryIndividualInvestor is IndividualPerson8 SecondaryIndividualInvestorValue)
        {
            writer.WriteStartElement(null, "ScndryIndvInvstr", xmlNamespace );
            SecondaryIndividualInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherIndividualInvestor is IndividualPerson8 OtherIndividualInvestorValue)
        {
            writer.WriteStartElement(null, "OthrIndvInvstr", xmlNamespace );
            OtherIndividualInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PrimaryCorporateInvestor is Organisation4 PrimaryCorporateInvestorValue)
        {
            writer.WriteStartElement(null, "PmryCorpInvstr", xmlNamespace );
            PrimaryCorporateInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SecondaryCorporateInvestor is Organisation4 SecondaryCorporateInvestorValue)
        {
            writer.WriteStartElement(null, "ScndryCorpInvstr", xmlNamespace );
            SecondaryCorporateInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (OtherCorporateInvestor is Organisation4 OtherCorporateInvestorValue)
        {
            writer.WriteStartElement(null, "OthrCorpInvstr", xmlNamespace );
            OtherCorporateInvestorValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "TrfrAcct", xmlNamespace );
        TransferorAccount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (NomineeAccount is Account16 NomineeAccountValue)
        {
            writer.WriteStartElement(null, "NmneeAcct", xmlNamespace );
            NomineeAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "Trfee", xmlNamespace );
        Transferee.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (CashAccount is CashAccount29 CashAccountValue)
        {
            writer.WriteStartElement(null, "CshAcct", xmlNamespace );
            CashAccountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PdctTrfAndRef", xmlNamespace );
        ProductTransferAndReference.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Extension is Extension1 ExtensionValue)
        {
            writer.WriteStartElement(null, "Xtnsn", xmlNamespace );
            ExtensionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ISATransfer12 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}

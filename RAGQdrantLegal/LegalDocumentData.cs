namespace RAG_Qdrant_Legal
{
    public static class LegalDocumentData
    {
        public static List<LegalDocument> GetDocuments()
        {
            return new List<LegalDocument>
            {
                new LegalDocument
                {
                    Title = "Non-Disclosure Agreement (NDA)",
                    Content = "This Non-Disclosure Agreement (the 'Agreement') is entered into by and between Company A and Company B to protect confidential information. The obligations are outlined in the following clauses: 1. Confidentiality Obligations – Each party agrees not to disclose or use confidential information for any purpose other than the permitted business dealings. 2. Exclusions – Confidentiality does not extend to information already public, or received independently by the recipient. 3. Governing Law – This Agreement is governed by the laws of the State of Example.\n"
                },
                new LegalDocument
                {
                    Title = "Employment Contract",
                    Content = "This Employment Contract, dated January 1, 2024, is by and between Employer (ABC Corp) and Employee (Jane Doe). 1. Duties – Employee will serve as Senior Analyst and report to Director of Analytics. 2. Compensation – Salary $80,000 per year, reviewed annually. 3. Benefits – Health insurance, 401(k) plan. 4. Termination – Either party may terminate with two weeks' notice. 5. Non-Compete – Employee shall not join direct competitors for 12 months post-termination.\n"
                },
                new LegalDocument
                {
                    Title = "Data Processing Addendum (DPA)",
                    Content = "This DPA supplements the Master Agreement. 1. Data Processing – Processor may process personal data only on documented instructions. 2. Security – Processor shall use appropriate measures (encryption, pseudonymization). 3. Breach Notification – Notify Controller of personal data breaches within 48 hours. 4. Subprocessing – No subprocessors without written consent of Controller. 5. Audit Rights – Controller may audit proof of compliance.\n"
                },
                new LegalDocument
                {
                    Title = "Service Level Agreement (SLA)",
                    Content = "This agreement is between Service Provider and Acme LLC. 1. Uptime Commitment – 99.9% monthly. 2. Support – Critical issues: 1 hr, High: 4 hrs, Normal: 24 hrs. 3. Penalties – Credits applied for downtime beyond 2 hours/month. 4. Exclusions – System downtime due to planned maintenance or force majeure excluded from SLA calculations.\n"
                },
                new LegalDocument
                {
                    Title = "Master Services Agreement (MSA)",
                    Content = "This MSA governs all Statements of Work (SOW) between Company A and Company B. 1. Scope – All deliverables and timelines defined per SOW. 2. Payment – 30 days net upon receipt of invoice. 3. IP Ownership – Work product is owned by Company A. 4. Indemnification – Each party indemnifies the other against third-party claims. 5. Dispute Resolution – Disputes settled by binding arbitration in New York.\n"
                },
                new LegalDocument
                {
                    Title = "Vendor Agreement",
                    Content = "Agreement between VendorCorp and BigCo. 1. Supply of Products – Vendor will supply goods as described in Exhibit A. 2. Quality Assurance – Products must pass inspection. 3. Pricing – As listed in Schedule A. 4. Confidentiality – Vendor agrees to maintain confidentiality of any proprietary BigCo information. 5. Default – If Vendor fails to perform, BigCo may terminate with written notice.\n"
                },
                new LegalDocument
                {
                    Title = "Software License Agreement",
                    Content = "Licensor grants to Licensee a non-exclusive right to use the Software. 1. License Restrictions – No reverse engineering or sublicensing. 2. Warranty Disclaimer – Software provided 'as is'. 3. Limitation of Liability – Licensor's liability shall not exceed license fees paid. 4. Maintenance – Updates provided annually. 5. Term & Termination – Agreement terminates after breach of any terms.\n"
                },
                new LegalDocument
                {
                    Title = "Privacy Policy",
                    Content = "This document describes the privacy practices of ExampleCo regarding personal data. 1. Data Collection – Types of personal data collected include name, email, device information. 2. Data Use – Used to improve service and for marketing. 3. Data Sharing – No sales of data. 4. Rights – Users may request data deletion or correction. 5. Changes – All changes to this policy will be posted on our website with date.\n"
                },
                new LegalDocument
                {
                    Title = "Purchase Order Terms and Conditions",
                    Content = "These terms govern all purchase orders issued by XYZ Inc. 1. Acceptance – Supplier's start of performance is acceptance. 2. Delivery – Must occur by date listed on PO. 3. Inspection – XYZ Inc. may reject non-conforming goods within 30 days. 4. Payment – 45 days net from invoice. 5. Warranties – Supplier warrants all goods are new and free from defect.\n"
                },
                new LegalDocument
                {
                    Title = "Remote Work Policy",
                    Content = "Company’s policy to support eligible employees to work remotely. 1. Eligibility – Any full-time employee after 6 months. 2. Security – All work must be performed using company VPN. 3. Meetings – Employees must attend all remote or in-person meetings on time. 4. Workspace – Employees must keep a distraction-free workspace.\n"
                },
                new LegalDocument
                {
                    Title = "Code of Conduct",
                    Content = "This code outlines expected behavior for all staff. 1. Respect – All employees will treat one another with dignity. 2. Safety – Safety protocols must always be followed. 3. Anti-Discrimination – No tolerance for discrimination based on age, gender, race, etc. 4. Reporting – Violations may be reported confidentially to HR.\n"
                },
                new LegalDocument
                {
                    Title = "Consulting Agreement",
                    Content = "Agreement between Client and Consultant. 1. Scope – Consultant will deliver the services described in Exhibit A. 2. Fees – $200/hour billed monthly. 3. Term – 6 months from commencement. 4. Independent Contractor – Consultant is not an employee. 5. Non-Solicitation – Client agrees not to hire Consultant's staff during or for 1 year after engagement.\n"
                },
                new LegalDocument
                {
                    Title = "Partnership Agreement",
                    Content = "Agreement entered by Partner A and Partner B. 1. Capital Contributions – Each Partner’s contributions are listed in Schedule 1. 2. Profit Sharing – Profits and losses shared equally unless otherwise amended. 3. Management – Major decisions require unanimous consent. 4. Withdrawal – Either Partner may withdraw with 60 days' written notice.\n"
                }
            };
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddFuel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("8a79bec2-7e0a-4a88-aa21-8f66c6bba590"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d7c2084-2612-4fba-a3a7-8c74f58b356b"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("6a49648e-46af-4622-8eab-ad1ea3ff2f7a"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 238, 27, 44, 187, 230, 200, 81, 96, 229, 172, 3, 198, 80, 141, 202, 235, 252, 160, 132, 207, 30, 147, 27, 107, 178, 28, 183, 204, 61, 59, 199, 149, 81, 214, 247, 217, 188, 152, 40, 194, 199, 63, 51, 135, 60, 177, 26, 183, 165, 17, 234, 237, 74, 6, 215, 173, 32, 73, 242, 37, 143, 177, 88, 142 }, new byte[] { 252, 143, 181, 17, 230, 114, 228, 143, 55, 217, 58, 122, 239, 52, 40, 74, 218, 96, 69, 225, 101, 210, 80, 102, 69, 19, 186, 123, 24, 26, 96, 247, 236, 80, 217, 9, 222, 47, 254, 93, 169, 150, 48, 56, 83, 124, 100, 193, 31, 162, 116, 129, 88, 166, 199, 3, 236, 185, 135, 167, 178, 117, 175, 150, 205, 49, 159, 46, 83, 111, 11, 108, 170, 153, 111, 10, 179, 117, 218, 106, 186, 75, 147, 96, 34, 99, 51, 1, 79, 186, 127, 4, 40, 255, 56, 64, 165, 164, 150, 73, 159, 183, 132, 185, 226, 71, 237, 109, 207, 37, 142, 252, 215, 116, 54, 138, 26, 123, 52, 12, 159, 69, 82, 153, 7, 221, 172, 12 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("273685c5-d848-4f3d-8bb0-1a3460864044"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("6a49648e-46af-4622-8eab-ad1ea3ff2f7a") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("273685c5-d848-4f3d-8bb0-1a3460864044"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6a49648e-46af-4622-8eab-ad1ea3ff2f7a"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("0d7c2084-2612-4fba-a3a7-8c74f58b356b"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 166, 233, 233, 19, 133, 29, 56, 218, 249, 250, 241, 251, 65, 205, 67, 177, 168, 30, 220, 76, 185, 74, 231, 215, 51, 224, 234, 25, 176, 6, 150, 119, 178, 118, 235, 135, 143, 100, 116, 93, 192, 7, 19, 47, 74, 65, 253, 72, 87, 27, 178, 46, 110, 182, 199, 196, 226, 240, 249, 68, 22, 57, 27, 91 }, new byte[] { 134, 118, 156, 103, 129, 149, 26, 239, 76, 241, 31, 237, 251, 107, 180, 171, 33, 95, 242, 142, 132, 131, 151, 163, 83, 250, 136, 102, 18, 137, 15, 217, 142, 84, 229, 149, 118, 66, 19, 184, 180, 200, 196, 40, 135, 46, 77, 177, 131, 119, 217, 171, 78, 1, 236, 18, 144, 174, 189, 130, 18, 249, 159, 52, 151, 120, 247, 64, 101, 182, 193, 140, 23, 20, 27, 228, 230, 205, 71, 152, 75, 160, 150, 233, 34, 86, 84, 253, 232, 112, 69, 102, 101, 8, 92, 253, 83, 228, 107, 33, 204, 143, 99, 154, 59, 160, 217, 122, 10, 63, 154, 64, 18, 131, 80, 69, 136, 221, 72, 66, 220, 82, 243, 44, 34, 127, 224, 136 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("8a79bec2-7e0a-4a88-aa21-8f66c6bba590"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("0d7c2084-2612-4fba-a3a7-8c74f58b356b") });
        }
    }
}

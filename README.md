# Design Patterns in <a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> </a>
## Tên khác: _Mẫu thiết kế phần mềm_

### 📚 Source & References: [Design Patterns in C#: A hands-on Guide with Real-World Examples - Vaskaran Sarcar](https://www.amazon.com/Design-Patterns-Hands-Real-world-Examples/dp/1484260619)
### 🧑 Translated & Compiled: [BuhZeeBu](https://github.com/TreNgheDiCode)
### 📝 Notes Version: [Notion's site](https://itclub-bubu.notion.site/itclub-bubu/424a10d8cf55478faa35524de41f6d5e?v=b30c0397f7b34771b4396ad64b9bfe44)

# 👋 Foreword (Lời nói đầu)
> Topic về Design Pattern dựa theo sơ đồ SDLC (Sofware Development Lifecycle - Vòng đời của ứng dụng) thì phần lớn sẽ nằm ở giai đoạn Evolution (Integration), tức là giai đoạn phát triển ứng dụng. Do đó, tiền đề học được Design Pattern, bạn phải nắm vững định nghĩa và cách hoạt động của lập trình hướng đối tượng, đồng thời mục tiêu cuối của lập trình viên chính là tạo ra các ứng dụng có thể chạy được đảm bảo đúng yêu cầu từ sếp và mấy người trên đầu mình, nên bạn chỉ nên học và áp dụng Design Pattern khi thật sự hiểu ứng dụng của bạn hoạt động và làm việc sử dụng như thế nào từ đó đưa vào các Pattern để cải tiến code của bạn cho nó suôn mượt như Sunsilk.

<div align="center">
<img src="https://www.notion.so/image/https%3A%2F%2Fprod-files-secure.s3.us-west-2.amazonaws.com%2F248343dc-1aa3-4172-969c-cabb3458bdcc%2F9c9345b6-ba0b-4910-a2de-26ac803ad99b%2FSDLC_-_Software_Development_Life_Cycle.jpg?table=block&id=7090679b-c821-4c52-bc08-a3b7cbe43c68&spaceId=248343dc-1aa3-4172-969c-cabb3458bdcc&width=2000&userId=7d1293b8-f702-4c3a-9701-3664ea57291c&cache=v2" width="200" height="200" />
</div>

> Mình viết lại dựa trên kiến thức đã học từ Youtube, từ tài liệu Ebook được đính kèm trong môn học tại trường cũng như là qua trải nghiệm và ứng dụng thử vào code, nên nó sẽ dân dã hơn thông qua cái nhìn và hiểu của mình. Mọi người nếu muốn hiểu thêm thì ngoài cuốn được đề cập đến trong giáo trình cũng có thể xem qua sách của GoF tên là Design Patterns: Elements of Reusable Object-Oriented Software (Cụ cố của Design Patterns). Ngôn ngữ sử dụng sẽ là C#.

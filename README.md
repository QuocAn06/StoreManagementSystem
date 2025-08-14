# Store Management System

## Giới thiệu
Dự án quản lý cửa hàng xây dựng bằng **ASP.NET Core MVC (.NET 6)** và **SQL Server**.
Hệ thống hỗ trợ quản lý bán hàng, nhập hàng, tồn kho, thống kê doanh thu, và **cập nhật dữ liệu real-time** với SignalR.

## Chức năng chính
- Quản lý sản phẩm (CRUD)
- Nhập hàng từ nhà cung cấp
- Bán hàng và in hóa đơn
- Quản lý tồn kho & lịch sử thay đổi
- Dashboard thống kê doanh thu, sản phẩm bán chạy, hàng tồn thấp
- Cập nhật dữ liệu real-time khi có đơn hàng/nhập hàng mới
- Quản lý người dùng & phân quyền (Admin, Nhân viên bán hàng, Nhân viên kho)

## Công nghệ sử dụng
- **Backend**: ASP.NET Core MVC (.NET 6)
- **Database**: SQL Server
- **ORM**: Entity Framework Core
- **Real-time**: SignalR
- **Frontend**: Razor Pages, Bootstrap 5, jQuery
- **Auth**: ASP.NET Identity
- **Chart**: Chart.js

## ERD (Entity Relationship Diagram)
```
	Users ───< Orders ───< OrderDetails >─── Books >─── Categories
                               ^
                               |
                         ImportDetails >─── ImportReceipts >─── Suppliers
```

![EntityRelationshipDiagram](https://drive.google.com/file/d/1qaJwA6UoRvdQeFoF6k6TffDoSoCXtleF/view?usp=sharing)

## Cấu trúc dự án
```
	StoreManagementSystem/
	├── Controllers/          # Controllers xử lý request
	├── Models/               # Models & ViewModels
	├── Data/                 # DbContext & Seed Data
	├── Services/             # Business logic
	├── Hubs/                 # SignalR Hubs
	├── Views/                # Razor Views
	├── wwwroot/              # Static files
	├── appsettings.json      # Cấu hình ứng dụng
	├── Program.cs            # Entry point của ứng dụng
	├── StoreManagementSystem.csproj
```

## ⚙️ Cách chạy dự án local
### 1. Clone repository:
```
   git clone https://github.com/username/StoreManagementSystem.git
	   cd StoreManagementSystem
```

### 2. Cấu hình chuỗi kết nối SQL Server trong appsettings.json:
```
		"ConnectionStrings": {
		  "DefaultConnection": "Server=YOUR_SERVER;Database=StoreDB;Trusted_Connection=True;"
		}
```

### 3. Chạy migration & seed data:
```
		dotnet ef database update
```

### 4. Chạy ứng dụng:
```
		dotnet run
```

### 5. Truy cập: https://localhost:5001

## 📸 Screenshots

(Thêm ảnh dashboard, danh sách sản phẩm, nhập hàng, bán hàng...)

## 👤 Tác giả

**Họ tên:** [Tên bạn]

**Liên hệ:** [Email hoặc LinkedIn]
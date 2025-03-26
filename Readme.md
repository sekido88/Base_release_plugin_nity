Base Auto Release Plugin Unity, using semantic-release, actions git

## Cách sử dụng
- Tạo biến môi trường cho NPM trên NPM tạo access token
- Vô github responsity -> setting -> secret -> new -> NPM_TOKEN
- Clone Project về là sử dụng được
  
1. Push code lên nhánh master
2. Sử dụng cấu trúc commit message tiêu chuẩn của semantic-release:
   - `fix: ...` - Sửa lỗi (tạo phiên bản patch)
   - `feat: ...` - Thêm tính năng mới (tạo phiên bản minor)
   - `feat!: ...` hoặc `fix!: ...` hoặc message có `BREAKING CHANGE` - Thay đổi lớn (tạo phiên bản major)

3. GitHub Actions sẽ tự động tạo release và cập nhật CHANGELOG.md

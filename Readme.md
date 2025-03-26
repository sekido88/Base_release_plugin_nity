Base Auto Release Plugin Unity, using semantic-release, Actions git

## Cách sử dụng

1. Push code lên nhánh master
2. Sử dụng cấu trúc commit message tiêu chuẩn của semantic-release:
   - `fix: ...` - Sửa lỗi (tạo phiên bản patch)
   - `feat: ...` - Thêm tính năng mới (tạo phiên bản minor)
   - `feat!: ...` hoặc `fix!: ...` hoặc message có `BREAKING CHANGE` - Thay đổi lớn (tạo phiên bản major)

3. GitHub Actions sẽ tự động tạo release và cập nhật CHANGELOG.md

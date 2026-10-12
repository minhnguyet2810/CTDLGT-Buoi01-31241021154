
# Kết quả thực nghiệm - Bài 3

## Phương pháp
- Thuật toán A: Brute Force - O(n²)
- Thuật toán B: Kadane - O(n)
- Công cụ đo: Stopwatch trong C#
- Chạy ở chế độ Release
- Thời gian trung bình của 5 lần đo

## Bảng kết quả

| Kích thước n | Brute Force (ms) | Kadane (ms) |
|---|---:|---:|
| 100 | 0.0297 | 0.0009 |
| 1000 | 0.7575 | 0.0177 |
| 10000 | 32.6776 | 0.0439 |

## Nhận xét
Khi kích thước mảng tăng, thời gian chạy của Brute Force tăng nhanh hơn Kadane. Với n = 10000, Brute Force mất 32.6776 ms, trong khi Kadane mất 0.0439 ms.

Hai thuật toán đều trả về kết quả giống nhau trên các dữ liệu đã kiểm thử.

## Kết luận
Kadane có độ phức tạp O(n), hiệu quả hơn Brute Force O(n²) khi kích thước mảng lớn.


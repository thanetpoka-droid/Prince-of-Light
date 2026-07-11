# 🎮 Prince of Light
**Unity 2D/3D Action-Adventure Game** (Development & Quality Assurance Showcase)

โปรเจกต์พัฒนาเกมคอมพิวเตอร์ด้วย **Unity Engine** และภาษา **C#** ที่มุ่งเน้นทั้งในส่วนของ Core Gameplay Mechanism และการออกแบบโครงสร้างโค้ดที่รองรับการทำ **Game Testing & Quality Assurance** เพื่อให้ตัวเกมทำงานได้อย่างเสถียรและมี Performance ที่ดีที่สุด

---

## 🛠 Tech Stack & Tools
* **Game Engine:** Unity
* **Language:** C#
* **Version Control:** Git / GitHub
* **Testing Scope:** Functional Testing, Playtesting, Regression Testing, UI Boundary Testing

---

## 🎯 Features & Core Mechanics
* **Character Controller:** ระบบควบคุมตัวละครที่ลื่นไหล รองรับ Input Validation เพื่อป้องกันบั๊กตัวละครติดกำแพงหรือตกแผนที่
* **State Machine:** ใช้โครงสร้าง Object-Oriented Programming (OOP) ในการควบคุมสถานะของตัวละคร (Idle, Run, Jump, Attack) เพื่อให้ง่ายต่อการทำ Unit Testing ในแต่ละ State
* **Asset Management:** การจัดเก็บโครงสร้างไฟล์ในระบบ `Assets`, `Packages`, และ `ProjectSettings` อย่างเป็นระบบ ป้องกันปัญหา Metafile เสียหายเมื่อทำงานร่วมกันเป็นทีม

---

## 🧪 Quality Assurance & Testing Approach (มุมมองการทดสอบเกม)
ในโปรเจกต์นี้มีการประยุกต์ใช้เทคนิค QA เพื่อให้เกมมีบั๊กน้อยที่สุด ดังนี้:

1. **Boundary & Collision Testing (การทดสอบขอบเขตคอลลิชัน):**
   * ทดสอบแรงกระทำ (Physics) และ Edge Cases ของกล่อง Collider เพื่อป้องกันไม่ให้ผู้เล่นหลุดออกนอกแผนที่ หรือเกิดบั๊กโพลีกอนทะลุ
2. **UI & Resolution Compatibility (การทดสอบหน้าจอแสดงผล):**
   * ตรวจสอบ UI Canvas และการจัด Anchor Points เพื่อให้มั่นใจว่าปุ่มกดและเมนูต่าง ๆ แสดงผลถูกต้องในทุกสเกลหน้าจอ (Aspect Ratios)
3. **Smoke Testing & Regression Testing:**
   * ทำการทดสอบระบบพื้นฐานทุกครั้งหลังจากการเพิ่มฟีเจอร์ใหม่ เพื่อเช็กว่าระบบเดิน/โจมตี/เมนูหลัก ไม่เกิดความเสียหายจากโค้ดชุดใหม่

---

## 📂 Project Structure
* `/Assets`: เก็บสคริปต์ C#, โมเดล/สไปรต์, อนิเมชัน และซีนของเกม
* `/Packages`: ระบบ Package Dependency ของ Unity
* `/ProjectSettings`: การตั้งค่าระบบฟิสิกส์, Input Manager และกราฟิกของตัวเกม
